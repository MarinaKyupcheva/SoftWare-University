// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
	using FestivalManager.Entities;
	using NUnit.Framework;
	using System;

	[TestFixture]
	public class StageTests
	{
		private Stage stage;
		private Performer performer;
		private Song song;

		[SetUp]
		public void SetUp()
		{
			stage = new Stage();
			performer = new Performer("Iv", "Mac", 23);
			song = new Song("How", new TimeSpan(0, 3, 30));
		}
		[Test]
		public void AddPerforToTheStage_WhenIsValidOperation()
		{
			stage.AddPerformer(performer);
			Assert.That(stage.Performers.Count, Is.EqualTo(1));
		}
		[Test]
		public void AddPerforToTheStage_WhenIsNull()
		{
			Performer performerTwo = null;


			Exception ex = Assert.Throws<ArgumentNullException>(() =>
			{
				this.stage.AddPerformer(performerTwo);
			});


		}
		[Test]
		public void AddPerforToTheStage_WhenIsUnderAge()
		{
			Performer performerTwo = new Performer("Stoyan", "Nikolov", 15);


			Exception ex = Assert.Throws<ArgumentException>(() =>
			{
				this.stage.AddPerformer(performerTwo);
			});

			Assert.That(ex.Message, Is.EqualTo("You can only add performers that are at least 18."));
		}
		[Test]

		public void AddSong_ValidateMethod()
		{
			Song songTwo = null;

			Assert.Throws<ArgumentNullException>(() => this.stage.AddSong(songTwo));
		}

		[Test]
		public void AddSong_WhenDurationIsUnderOneMinute()
		{
			Song songTwo = new Song("How much", new TimeSpan(0));

			Exception ex = Assert.Throws<ArgumentException>(() =>
			{
				this.stage.AddSong(songTwo);
			});

			Assert.That(ex.Message, Is.EqualTo("You can only add songs that are longer than 1 minute."));
		}

		[Test]
		public void Test_AddSongToPerformer()
		{
			stage.AddPerformer(performer);
			stage.AddSong(song);
			var message = stage.AddSongToPerformer(song.Name, performer.FullName);
			Assert.AreEqual(message, $"{song.Name} will be performed by {performer.FullName}");
		}

		[Test]
		public void Test_AddSongToPerformerWhenSongIsNull()
		{
			stage.AddPerformer(performer);
			stage.AddSong(new Song(null, new TimeSpan(2, 20, 30)));
			
			Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer(song.Name, performer.FullName));
		}

		[Test]
		public void GetPerformer_WhenIsNull()
		{
			stage.AddPerformer(new Performer(null, null, 25));
			stage.AddSong(song);

			Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer(song.Name, performer.FullName));
		}

		[Test]
		public void GetPerformer_WhenIsInvalid()
		{
			stage.AddPerformer(performer);
			stage.AddSong(song);

			var invalidPerformer = new Performer("Kaya", "Raya", 12);

			Exception ex = Assert.Throws<ArgumentException>(() =>
			{
				stage.AddSongToPerformer("How", invalidPerformer.FullName);
			});

			Assert.That(ex.Message, Is.EqualTo("There is no performer with this name."));
		}

		[Test]
		public void GetSong_WhenIsInvalid()
		{
			stage.AddPerformer(performer);
			stage.AddSong(song);

			var invalidSong = new Song("Kaya", new TimeSpan(0, 0, 20));

			Exception ex = Assert.Throws<ArgumentException>(() =>
			{
				stage.AddSongToPerformer("Kaya", performer.FullName);
			});

			Assert.That(ex.Message, Is.EqualTo("There is no song with this name."));
		}
	}
}